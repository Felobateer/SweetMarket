import { View, Text, Button } from "react-native";
import Navbar from "../components/Navbar";

export default function Home({ navigation }) {
  return (
    <View>
      <Navbar navigation={navigation} />
      <Text>HomePage</Text>
      <Button
        title="Go to About"
        onPress={() => navigation.navigate("about")}
      />
    </View>
  );
}
