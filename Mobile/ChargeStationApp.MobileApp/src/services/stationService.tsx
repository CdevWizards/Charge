// Mobile/ChargeStationApp.MobileApp/src/services/stationService.ts
import axios from 'axios';

const BASE_URL = 'http://localhost:5000/api'; // Web API'nin çalıştığı adres

export const getStations = async () => {
  const response = await axios.get(`${BASE_URL}/charge`);
  return response.data;
};
