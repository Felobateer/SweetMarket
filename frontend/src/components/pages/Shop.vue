<script>
import Card from "../sections/Card.vue";

export default {
  name: "Shop",
  components: {
    Card,
  },
};
</script>

<template>
  <main class="w-full flex justify-center">
    <section
      class="bg-orange-500 p-4 my-4 flex flex-col rounded-lg shadow-md shadow-orange-200 w-3/4 h-fit"
    >
      <div class="relative flex justify-center w-3/4 mx-auto">
        <input
          type="text"
          id="SearchBar"
          placeholder="Type the name to search for the product"
          class="w-full h-8 rounded-lg mx-auto py-2 px-8"
        />
        <i
          class="fa-solid fa-magnifying-glass absolute left-2 top-2 text-orange-500"
        ></i>
      </div>
      <section class="w-3/4 mx-auto h-fit flex flex-row justify-evenly mt-3">
        <div>
          <select
            class="appearance-none bg-transparent text-white rounded-lg border-gray-200 border-2 p-1"
          >
            <option class="text-black" value="" default>
              Choose a Category
            </option>
            <option class="text-black">Chocolate</option>
            <option class="text-black">Ice-cream Cone</option>
            <option class="text-black">Ice-cream Bucket</option>
            <option class="text-black">Cake</option>
          </select>
        </div>
        <div>
          <select
            class="appearance-none bg-transparent text-white rounded-lg border-gray-200 border-2 p-1"
            name=""
            id=""
          >
            <option class="text-black" value="">Choose a Size</option>
            <option class="text-black" value="small">Small</option>
            <option class="text-black" value="big">Family</option>
          </select>
        </div>
        <div>
          <select
            class="appearance-none bg-transparent text-white rounded-lg border-gray-200 border-2 p-1"
            name=""
            id=""
          >
            <option class="text-black text-center" value="">Specials</option>
            <option class="text-black" value="">Discounts</option>
            <option class="text-black" value="">Offers</option>
          </select>
        </div>
        <div>
          <select
            class="appearance-none bg-transparent text-white rounded-lg border-gray-200 border-2 p-1"
            name=""
            id=""
          >
            <option class="text-black text-center" value="">Price</option>
            <option class="text-black" value="">0 - 5&euro;</option>
            <option class="text-black" value="">5&euro; - 10&euro;</option>
            <option value="" class="text-black">>10&euro;</option>
          </select>
        </div>
      </section>
    </section>
    <section>
      <!-- <Card :items="merchendize" /> -->
    </section>
  </main>
</template>

<style scoped></style>
