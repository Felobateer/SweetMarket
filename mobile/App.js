import { NavigationContainer } from "@react-navigation/native";
import { createStackNavigator } from "@react-navigation/stack";
import Home from "./screens/Home";
import About from "./screens/About";
import Shop from "./screens/Shop";
import Account from "./screens/Account";
import tw from "twrnc";

const Stack = createStackNavigator();

export default function App() {
  return (
    <NavigationContainer>
      <Stack.Navigator initialRouteName="Home">
        <Stack.Screen name="home" component={Home} />
        <Stack.Screen name="about" component={About} />
        <Stack.Screen name="shop" component={Shop} />
        <Stack.Screen name="account" component={Account} />
      </Stack.Navigator>
    </NavigationContainer>
  );
}
