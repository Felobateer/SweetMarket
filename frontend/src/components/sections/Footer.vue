<script>
export default {
  name: "Footer",
  data() {
    return {
      list: [
        { name: "about", links: ["history", "location", "our CEO"] },
        {
          name: "our Products",
          links: ["offers", "discounts", "all products"],
        },
        { name: "other", links: ["log-in", "cart"] },
      ],
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
  <footer class="bg-orange-500 p-10">
    <section class="flex flex-row justify-evenly">
      <div v-for="item in list" :key="item.name">
        <h2 class="text-white text-xl font-semibold">{{ cfl(item.name) }}</h2>
        <ul v-for="link in item.links" :key="link">
          <li class="text-gray-200 cursor-pointer">
            {{ cfl(link) }}
          </li>
        </ul>
      </div>
    </section>
    <div class="mt-8">
      <p class="text-gray-200 text-md text-center">
        Feel free to visit our store. Come to: Otto Lilienthal Str. 12a 28199
        Bremen Germany
      </p>
      <p class="text-gray-200 text-md text-center">@Felobateer-Saadalla</p>
    </div>
  </footer>
</template>

<style></style>
