import Home from "./Home.vue";
import About from "./About.vue";
import Shop from "./Shop.vue";
import Account from "./Account.vue";
import { createRouter, createWebHistory } from "vue-router";

const routes = [
  { path: "/", component: Home },
  { path: "/about", component: About },
  { path: "/shop", component: Shop },
  { path: "/account", component: Account },
];

const router = createRouter({
  history: createWebHistory(), // For browser history navigation
  routes,
});

export default router;
