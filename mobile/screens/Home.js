import { View, Text, Button } from "react-native";

export default function Home({ navigation }) {
  return (
    <View>
      <Text>HomePage</Text>
      <Button
        title="Go to About"
        onPress={() => navigation.navigate("about")}
      />
    </View>
  );
}
