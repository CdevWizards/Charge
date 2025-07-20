import { Text, View, Button } from 'react-native';
import { Link } from 'expo-router';

export default function HomeScreen() {
  return (
    <View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
      <Text style={{ fontSize: 24, marginBottom: 20 }}>⚡️ ChargeStationAppe Hoş Geldiniz!</Text>

      <Link href="/(tabs)/explore" asChild>
        <Button title="İstasyonları Keşfet →" />
      </Link>
    </View>
  );
}
