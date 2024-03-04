<script>
export default {
  name: "Navbar",
  data() {
    return {
      pages: ["home", "about", "shop", "account"],
    };
  },
  methods: {
    cfl(word) {
      return word.charAt(0).toUpperCase() + word.slice(1);
    },
  },
};
</script>

<template>
  <nav class="bg-orange-500 flex flex-row justify-between px-40 md:px-20">
    <div class="flex flex-row px-4 py-3">
      <img
        src="../../assets/sweetmarket-logo.jpg"
        alt="logo"
        class="rounded-md w-16 h-16"
      />
      <h1 class="text-white font-bold text-3xl ml-8 mt-4 font-mono">
        SweetMarket
      </h1>
    </div>
    <ul class="flex flex-row justify-evenly">
      <li
        v-for="(page, index) in pages"
        :key="page"
        class="text-gray-100 text-xl font-semibold mx-2 mt-8 mb-6 hover:text-gray-50 hover:border-b-slate-200 hover:border-b-4"
      >
        <router-link :to="index === 0 ? '/' : `/${page}`">{{
          cfl(page)
        }}</router-link>
      </li>
    </ul>
  </nav>
</template>

<style></style>
