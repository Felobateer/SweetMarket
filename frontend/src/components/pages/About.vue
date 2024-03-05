<script>
export default {
  name: "About",
  data() {
    return {
      abouts: ["History", "Location", "Our CEO"],
    };
  },
};
</script>

<template>
  <div class="p-4" v-for="about in abouts" :key="about">
    <h1 class="text-2xl font-serif text-orange-700">{{ about }}</h1>
    <p class="p-2">
      Lorem ipsum dolor sit amet consectetur adipisicing elit. Atque veritatis
      enim fuga aliquid. Aliquam sapiente cum nobis tenetur. Adipisci doloremque
      id aut dolores amet vitae tenetur nisi odit aliquid ipsam? Lorem ipsum
      dolor sit, amet consectetur adipisicing elit. Atque, labore! Culpa
      distinctio eligendi perspiciatis expedita voluptatum repellat veniam, cum
      delectus quaerat similique tenetur sint ut qui vitae eum quas numquam?
      Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ratione
      consequuntur labore a eum quibusdam, asperiores at inventore vel, odio
      ipsam eos esse! Laudantium magnam numquam laboriosam maiores eligendi
      minus totam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Sed
      assumenda suscipit dolore molestias sit, fugit, maxime aliquam recusandae
      rerum non similique neque at tempora maiores repudiandae asperiores
      expedita facere dolorum.
    </p>
  </div>
</template>

<style scoped></style>
