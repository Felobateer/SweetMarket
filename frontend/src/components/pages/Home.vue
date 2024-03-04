<script>
import Landing from "../sections/Landing.vue";
import Offers from "../sections/Offers.vue";

export default {
  name: "Home",
  components: {
    Landing,
    Offers,
  },
};
</script>

<template>
  <Landing />
  <Offers />
  <h1>Home</h1>
</template>

<style scoped></style>
