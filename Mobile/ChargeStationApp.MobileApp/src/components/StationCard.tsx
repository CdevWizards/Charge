// Mobile/ChargeStationApp.MobileApp/src/components/StationCard.tsx
import React from 'react';
import { View, Text, StyleSheet } from 'react-native';

const StationCard = ({ name, provider, price }: { name: string; provider: string; price: number }) => {
  return (
    <View style={styles.card}>
      <Text>{name}</Text>
      <Text>{provider}</Text>
      <Text>{price} ₺/kWh</Text>
    </View>
  );
};

const styles = StyleSheet.create({
  card: {
    padding: 16,
    margin: 8,
    backgroundColor: '#eee',
    borderRadius: 10,
  },
});

export default StationCard;
