<script>
export default {
  name: "SlideShow",
  data() {
    return {
      currentSlide: 0,
      slides: [
        { title: "Slide 1", image: "slide1.jpg" },
        { title: "Slide 2", image: "slide2.jpg" },
        { title: "Slide 3", image: "slide3.jpg" },
        // Add more slides as needed
      ],
    };
  },
  methods: {
    nextSlide() {
      this.currentSlide = (this.currentSlide + 1) % this.slides.length;
      this.translateSlides();
    },
    prevSlide() {
      this.currentSlide =
        (this.currentSlide - 1 + this.slides.length) % this.slides.length;
      this.translateSlides();
    },
    translateSlides() {
      const slideWidth = this.$el.offsetWidth;
      const translateX = -slideWidth * this.currentSlide;
      this.$el.querySelector(
        ".flex"
      ).style.transform = `translateX(${translateX}px)`;
    },
  },
};
</script>

<template>
  <div class="relative overflow-hidden bg-gray-200">
    <div
      class="relative flex justify-between transition-transform duration-300 transform translate-x-0"
    >
      <!-- Slides -->
      <div class="flex">
        <div
          v-for="(slide, index) in slides"
          :key="index"
          class="flex-shrink-0 w-full"
        >
          <img :src="slide.image" :alt="slide.title" class="w-full" />
        </div>
      </div>

      <!-- Previous Button -->
      <button
        @click="prevSlide"
        class="absolute left-0 top-0 bottom-0 flex items-center justify-center w-12 bg-gray-800 bg-opacity-50 text-white transition-opacity duration-300 opacity-0 hover:opacity-100 focus:outline-none"
      >
        <svg class="w-6 h-6" fill="currentColor" viewBox="0 0 20 20">
          <path
            fill-rule="evenodd"
            d="M9.293 6.293a1 1 0 011.414 0L15 10l-4.293 4.293a1 1 0 01-1.414-1.414L12.586 10 9.293 6.707a1 1 0 010-1.414z"
            clip-rule="evenodd"
          ></path>
        </svg>
      </button>

      <!-- Next Button -->
      <button
        @click="nextSlide"
        class="absolute right-0 top-0 bottom-0 flex items-center justify-center w-12 bg-gray-800 bg-opacity-50 text-white transition-opacity duration-300 opacity-0 hover:opacity-100 focus:outline-none"
      >
        <svg class="w-6 h-6" fill="currentColor" viewBox="0 0 20 20">
          <path
            fill-rule="evenodd"
            d="M10.707 13.707a1 1 0 01-1.414 0L5 10l4.293-4.293a1 1 0 011.414 1.414L7.414 10l3.293 3.293a1 1 0 010 1.414z"
            clip-rule="evenodd"
          ></path>
        </svg>
      </button>
    </div>
  </div>
</template>

<style scoped></style>
