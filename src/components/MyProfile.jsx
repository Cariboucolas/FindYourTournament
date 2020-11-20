import React from 'react';
import { Link } from 'react-router-dom';

import "../styles/MyProfile.css"

const knightInfo = [
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
    "ranking": 1
  }
]

function MyProfile() {


  return (
    <>
      <Link to="/" >
        <h1 className="site-logo">FYT</h1>
      </Link>
      <h1>My profile</h1>
      {
        knightInfo.map(item => {
          return (
            <div>
              <div className="header-profile">
                <img src={item.avatar} />
                <h3>{item.knightName}</h3>
                <div>{item.age}</div>
                <div>{item.alive ? "Alive" : "Dead"}</div>
              </div>
              <div className="profile-container">
                <div>Number of victories: {item.victories}</div>
                <div>Number of defeats: {item.defeats}</div>
              </div>

              <div className="profile-info-container">
                <div className="profile-container">
                  <h4>My stats</h4>
                  <div>Rank: {item.ranking}</div>
                  <div>
                    <img src={item.badge} alt="badge" />
                  </div>
                  <div>
                    <img src={item.banner} alt="badge" />
                  </div>
                </div>

                <div className="profile-container">
                  <h4>My caracteristics</h4>
                  <div>My weapons: {item.weapons}</div>
                  <div>My mount: {item.mount ? item.mountType + "Name:" + item.mountName : "none"}</div>
                  <div>Gear: {item.armors}</div>
                  <div>Region: {item.region}</div>
                  <div>Pigeon: {item.pigeon}</div>
                  <div>Moto: {item.moto}</div>
                </div>
              </div>

              <h4>Tournaments coming up</h4>
            </div>
          )

        })
      }
    </>

  )
}

export default MyProfile;