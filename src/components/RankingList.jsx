import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import axios from "axios";
import "../styles/RankingList.css";
import RankingCard from './RankingCard';

// const knightsArr = [
//   {
//     "knightId": 3,
//     "knightName": "Leonidas",
//     "age": 35,
//     "victories": 65,
//     "defeats": 0,
//     "badge": "",
//     "weapons": "sword, spear, shield",
//     "armors": "pants",
//     "mount": true,
//     "mountType": "Man",
//     "mountName": "Xerxès",
//     "moto": "WAHOU",
//     "avatar": "",
//     "region": "Greecce",
//     "pigeon": "sparte@pigeon.com",
//     "alive": true,
//     "ranking": 1
//   },
//   {
//     "knightId": 4,
//     "knightName": "Maximus",
//     "age": 30,
//     "victories": 25,
//     "defeats": 2,
//     "badge": "",
//     "weapons": "sword , sword",
//     "armors": "chestplate",
//     "mount": false,
//     "mountType": "",
//     "mountName": "",
//     "moto": "Force et honneur.",
//     "avatar": "",
//     "region": "Rome",
//     "pigeon": "VillaPoggioManzuoli@pigeon.com",
//     "alive": true,
//     "ranking": 2
//   },
//   {
//     "knightId": 1,
//     "knightName": "La machine",
//     "age": 25,
//     "victories": 5,
//     "defeats": 0,
//     "badge": "",
//     "weapons": "sword , shield",
//     "armors": "Plate Armor",
//     "mount": false,
//     "mountType": "",
//     "mountName": "",
//     "moto": "Banzai",
//     "avatar": "",
//     "region": "Occitanie",
//     "pigeon": "",
//     "alive": true,
//     "ranking": 3
//   },
//   {
//     "knightId": 2,
//     "knightName": "Le jeunot",
//     "age": 16,
//     "victories": 0,
//     "defeats": 0,
//     "badge": "",
//     "weapons": "Wood stick",
//     "armors": "goat leather",
//     "mount": false,
//     "mountType": "",
//     "mountName": "",
//     "moto": "Ne me tuez pas",
//     "avatar": "",
//     "region": "Breton",
//     "pigeon": "",
//     "alive": true,
//     "ranking": 4
//   },
//   {
//     "knightId": 5,
//     "knightName": "Guillaume",
//     "age": 28,
//     "victories": 100,
//     "defeats": 0,
//     "badge": "",
//     "weapons": "More humans",
//     "armors": "Big walls",
//     "mount": false,
//     "mountType": "",
//     "mountName": "",
//     "moto": "I have an army",
//     "avatar": "",
//     "region": "Mésopotamie",
//     "pigeon": "Angleterre@pigeon.com",
//     "alive": false,
//     "ranking": 5
//   }
// ]

function RankingList() {

  const [knights, setKnights] = useState([])
  const url = "https://backhackaton20201120055355.azurewebsites.net/FYT/knight" 
  // axios request to get tournaments
  const getKnights =()=>{
    axios
        .get(url)
        .then((res)=> setKnights(res.data))
        .catch((error) => {
            console.error(error);
          });   
}
  useEffect(() => {
    getKnights();
  }, [])

  return (
    <>
      <Link to="/" >
        <h1 className="site-logo">FYT</h1>
      </Link>
      <div className="ranking-list">
        <h1>Rankings</h1>
        {knights.map(item =>
          <RankingCard knight={item} />
        )}
      </div>
    </>
  )
}

export default RankingList;