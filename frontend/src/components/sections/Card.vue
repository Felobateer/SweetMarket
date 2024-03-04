<script>
export default {
  name: "Card",
  props: { item: Object },
};
</script>

<template>
  <section class="flex flex-col">
    <img :src="item.img" :alt="item.name" />
    <div>
      <p class="text-lg font-semibold text-orange-700">
        {{ item.name }}
      </p>

      <p v-if="item.description" class="text-md text-orange-600">
        {{ item.description }}
      </p>

      <p class="text-md text-orange-600">&euro; {{ item.price }}</p>

      <button
        class="bg-orange-500 p-4 text-gray-100 hover:bg-orange-600 hover:text-white after:bg-orange-800"
      >
        Add to cart
      </button>
    </div>
  </section>
</template>

<style scoped></style>
