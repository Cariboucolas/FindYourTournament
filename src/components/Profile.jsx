import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';


const knightsArr = [
  {
    "knightId": 3,
    "knightName": "Leonidas",
    "age": 35,
    "victories": 65,
    "defeats": 0,
    "badge": "",
    "weapons": "sword, spear, shield",
    "armors": "pants",
    "mount": true,
    "mountType": "Man",
    "mountName": "Xerxès",
    "moto": "WAHOU",
    "avatar": "",
    "region": "Greecce",
    "pigeon": "sparte@pigeon.com",
    "alive": true,
    "ranking": 1
  },
  {
    "knightId": 4,
    "knightName": "Maximus",
    "age": 30,
    "victories": 25,
    "defeats": 2,
    "badge": "",
    "weapons": "sword , sword",
    "armors": "chestplate",
    "mount": false,
    "mountType": "",
    "mountName": "",
    "moto": "Force et honneur.",
    "avatar": "",
    "region": "Rome",
    "pigeon": "VillaPoggioManzuoli@pigeon.com",
    "alive": true,
    "ranking": 2
  },
  {
    "knightId": 1,
    "knightName": "La machine",
    "age": 25,
    "victories": 5,
    "defeats": 0,
    "badge": "",
    "weapons": "sword , shield",
    "armors": "Plate Armor",
    "mount": false,
    "mountType": "",
    "mountName": "",
    "moto": "Banzai",
    "avatar": "",
    "region": "Occitanie",
    "pigeon": "",
    "alive": true,
    "ranking": 3
  },
  {
    "knightId": 2,
    "knightName": "Le jeunot",
    "age": 16,
    "victories": 0,
    "defeats": 0,
    "badge": "",
    "weapons": "Wood stick",
    "armors": "goat leather",
    "mount": false,
    "mountType": "",
    "mountName": "",
    "moto": "Ne me tuez pas",
    "avatar": "",
    "region": "Breton",
    "pigeon": "",
    "alive": true,
    "ranking": 4
  },
  {
    "knightId": 5,
    "knightName": "Guillaume",
    "age": 28,
    "victories": 100,
    "defeats": 0,
    "badge": "",
    "weapons": "More humans",
    "armors": "Big walls",
    "mount": false,
    "mountType": "",
    "mountName": "",
    "moto": "I have an army",
    "avatar": "",
    "region": "Mésopotamie",
    "pigeon": "Angleterre@pigeon.com",
    "alive": false,
    "ranking": 5
  }
]

function Profile() {

  const { id } = useParams();
  const [knight, setKnight] = useState([]);

  useEffect(() => {
    knightsArr.map(knight =>
      knight.knightId == id ? setKnight(knight) : []
    )
  }, [id])

  return (

    <div>
      <div className="header-profile">
        <img src={knight.avatar} />
        <h3>{knight.knightName}</h3>
        <div>{knight.age}</div>
        <div>{knight.alive ? "Alive" : "Dead"}</div>
      </div>
      <div className="profile-container">
        <div>Number of victories: {knight.victories}</div>
        <div>Number of defeats: {knight.defeats}</div>
      </div>

      <div className="profile-info-container">
        <div className="profile-container">
          <h4>My stats</h4>
          <div>Rank: {knight.ranking}</div>
          <div>
            <img src={knight.badge} alt="badge" />
          </div>
          <div>
            <img src={knight.banner} alt="badge" />
          </div>
        </div>

        <div className="profile-container">
          <h4>My caracteristics</h4>
          <div>My weapons: {knight.weapons}</div>
          <div>My mount: {knight.mount ? knight.mountType + "Name:" + knight.mountName : "none"}</div>
          <div>Gear: {knight.armors}</div>
          <div>Region: {knight.region}</div>
          <div>Pigeon: {knight.pigeon}</div>
          <div>Moto: {knight.moto}</div>
        </div>
      </div>
    </div>

  )
}


export default Profile;