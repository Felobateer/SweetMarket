import React from "react";
import { View, Text, Image, FlatList, TouchableOpacity } from "react-native";
import tw from "twrnc";
import logo from "../assets/sweetmarket-logo.jpg";

export default function Navbar({ navigation }) {
  const pages = ["home", "about", "shop", "account"];

  const cfl = (word) => {
    return word.charAt(0).toUpperCase() + word.slice(1);
  };
  return (
    <View style={tw`bg-orange-500 flex flex-row justify-between`}>
      <View style={tw`flex flex-row px-2 py-1`}>
        <Image source={logo} alt="logo" style={tw`rounded-md w-12 h-12`} />
        <Text style={tw`text-white font-bold text-xl ml-4 mt-2 font-mono`}>
          SweetMarket
        </Text>
      </View>
      <FlatList
        data={pages}
        renderItem={({ item: page }) => (
          <View
            key={page}
            style={tw`text-gray-100 text-sm font-semibold mx-2 mt-8 mb-6 hover:text-gray-50 hover:border-b-slate-200 hover:border-b-4`}
          >
            {/* Replace this with your actual navigation logic for React Native */}
            {/* Example using navigation prop for React Navigation */}
            <TouchableOpacity onPress={() => navigation.navigate(`${page}`)}>
              <Text
                style={tw`text-gray-100 text-sm font-semibold mx-2 mt-8 mb-6 hover:text-gray-50 hover:border-b-slate-200 hover:border-b-4`}
              >
                {cfl(page)}
              </Text>
            </TouchableOpacity>
          </View>
        )}
        horizontal
      />
    </View>
  );
}
