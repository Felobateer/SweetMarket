<script>
import Card from "./Card.vue";

export default {
  name: "Offers",
  components: { Card },
  data() {
    return {
      products: [
        {
          name: "ice cream",
          description: "it's an ice cream",
          price: 2000,
          id: 0,
          img: "../../assets/ice-cream.jpg",
        },
      ],
    };
  },
};
</script>

<template>
  <article>
    <h1 class="text-orange-700 text-2xl mx-16">Our Offers</h1>
    <Card :item="products[0]" />
  </article>
</template>

<style></style>
