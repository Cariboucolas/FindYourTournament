import React from 'react';
import { Link } from 'react-router-dom';
import Footer from "./Footer";
import "../styles/MyProfile.css"

const knightInfo = [
  {
    "knightId": 22,
    "knightName": "Holdjamy",
    "age": 34,
    "victories": 25,
    "defeats": 4,
    "banner": "",
    "weapons": "Hammer",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Vikings armor",
    "armorsIcons": "",
    "mount": true,
    "mountType": "Wolf",
    "mountTypeIcons": "",
    "mountName": "Canis",
    "moto": "I have thor's hammer!",
    "avatar": "",
    "region": "",
    "pigeon": "@pigeon.com",
    "pigeonIcons": "",
    "alive": true,
    "aliveIcons": "",
    "ranking": 2,
    "rankingIcons": "",
    "successIcons": ""
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
                <img className="avatar-list" src={item.avatar} />
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
                  <img className="icon" src={item.weaponsIcons} alt="weapon" />
                  <div>My weapons: {item.weapons}
                  </div>
                  <div>My mount: {item.mount ? item.mountType + "Name:" + item.mountName : "none"}</div>
                  <div>Gear: {item.armors}</div>
                  <div>Region: {item.region}</div>
                  <div>Pigeon: {item.pigeon}</div>
                  <div>Moto: {item.moto}</div>
                </div>
              </div>
            </div>
          )

        })
      }
      <Footer />
    </>

  )
}

export default MyProfile;