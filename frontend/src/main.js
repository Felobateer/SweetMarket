import { createApp } from "vue";
import "./style.css";
import App from "./App.vue";
import router from "./components/pages";

const app = createApp(App);
app.use(router); // Use the router in the app
app.mount("#app");
