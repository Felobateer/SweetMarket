<script>
export default {
  name: "Card",
  props: { item: Object },
};
</script>

<template>
  <section v-if="item" class="flex flex-col w-52 m-6">
    <img :src="item.img" :alt="item.name" />
    <img src="../../assets/ice-cream.jpg" class="rounded-md" alt="" />
    <div>
      <p class="text-lg font-semibold text-orange-700">
        {{ item.name }}
      </p>

      <p v-if="item.description" class="text-md text-orange-600">
        {{ item.description }}
      </p>
      <div class="flex flex-row justify-between mt-3">
        <p class="text-md text-orange-600 mt-1">&euro; {{ item.price }}</p>

        <button
          class="bg-orange-500 py-1 px-4 rounded-md text-gray-100 hover:bg-orange-600 hover:text-white after:bg-orange-800"
        >
          Add to cart
        </button>
      </div>
    </div>
  </section>
</template>

<style scoped></style>
