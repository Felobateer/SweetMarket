<template>
  <Landing />
  <Offers />
  <SlideShow />
</template>

<script>
import Landing from "../sections/Landing.vue";
import Offers from "../sections/Offers.vue";
import SlideShow from "../sections/SlideShow.vue";

export default {
  name: "Home",
  components: {
    Landing,
    Offers,
    SlideShow,
  },
};
</script>
<style scoped></style>
