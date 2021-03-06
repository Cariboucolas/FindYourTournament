import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { useParams } from 'react-router-dom';
import '../styles/Profile.css';


const knightsArr = [
  {
    "knightId": 1,
    "knightName": "Nulfar",
    "age": 29,
    "victories": 1,
    "defeats": 8,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_8.png",
    "weapons": "Sword",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Harness",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
        "mountTypeIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png",
    "mountName": "",
    "moto": "I will be the best !",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Nulfar.png",
    "region": "Aquitaine",
    "pigeon": "Nulfar_Aquitaine@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": false,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png",
    "ranking": 24,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 2,
    "knightName": "Telperce",
    "age": 28,
    "victories": 14,
    "defeats": 8,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_3.png",
    "weapons": "Spear",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Harness",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "Call me the last punishment",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Telperce.png",
    "region": "Lyonnois",
    "pigeon": "Telperce_Lyonnois@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 12,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 3,
    "knightName": "Tanje",
    "age": 24,
    "victories": 7,
    "defeats": 3,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_2.png",
    "weapons": "Sword",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Breastplate",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "I learn every day",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Tanje.png",
    "region": "Berry",
    "pigeon": "Tanje_Berry@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 16,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 4,
    "knightName": "Rollrein",
    "age": 21,
    "victories": 3,
    "defeats": 1,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_1.png",
    "weapons": "Mace",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Chainmail",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "I have the courage to face the greatest",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Rollrein.png",
    "region": "Francie",
    "pigeon": "Rollrein_Francie@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 19,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 5,
    "knightName": "Reindric",
    "age": 44,
    "victories": 37,
    "defeats": 25,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_1.png",
    "weapons": "Sword",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Plate Armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "There was a time when i was first",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Reindric.png",
    "region": "Francie",
    "pigeon": "Reindric_Francie@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 10,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png",
    "successIcons": "https://cdn.discordapp.com/attachments/778897010711330846/779148773964120084/success_2tournament.png"
  },
  {
    "knightId": 6,
    "knightName": "Valeranos",
    "age": 27,
    "victories": 9,
    "defeats": 4,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_6.png",
    "weapons": "Scourge",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Plate Armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": true,
    "mountType": "Camel",
    "mountTypeIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png",
    "mountName": "Case",
    "moto": "Say your prayer",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Valeranos.png",
    "region": "Normaundie",
    "pigeon": "Valeranos_Normaundie@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 8,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png",
    "successIcons": ""
  },
  {
    "knightId": 7,
    "knightName": "Tuslot",
    "age": 27,
    "victories": 0,
    "defeats": 1,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_7.png",
    "weapons": "Dagger",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Quilted weave",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "Let's go",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Tuslot.png",
    "region": "Orleanois",
    "pigeon": "Tuslot_Orleanois@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": false,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png",
    "ranking": 22,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 8,
    "knightName": "Nardarnold",
    "age": 27,
    "victories": 5,
    "defeats": 4,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_4.png",
    "weapons": "Scourge",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Scale Armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "Could you be nice to me ?",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Nardarnold.png",
    "region": "Chaimpaigne",
    "pigeon": "Nardarnold_Chaimpagne@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 18,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 9,
    "knightName": "Jeain",
    "age": 27,
    "victories": 17,
    "defeats": 9,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_8.png",
    "weapons": "Mace",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Chainmail",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": true,
    "mountType": "Unicorn",
    "mountTypeIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png",
    "mountName": "Pony",
    "moto": "Do you know the realy death ?",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Jeain.png",
    "region": "Aquitaine",
    "pigeon": "Jeain_Aquitaine@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 7,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png",
    "successIcons": ""
  },
  {
    "knightId": 10,
    "knightName": "Bojas",
    "age": 18,
    "victories": 4,
    "defeats": 4,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_5.png",
    "weapons": "Spear",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Breastplate",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "Drop to my halberd",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Bojas.png",
    "region": "Languedoc",
    "pigeon": "Bojas_Languedoc@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 17,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 11,
    "knightName": "Agaaut",
    "age": 28,
    "victories": 19,
    "defeats": 8,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_5.png",
    "weapons": "Hallebarde",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Plate armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "Drop to my halberd",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Agaaut.png",
    "region": "Languedoc",
    "pigeon": "Agaaut_Languedoc@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 6,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png",
    "successIcons": ""
  },
  {
    "knightId": 12,
    "knightName": "Thurward",
    "age": 36,
    "victories": 14,
    "defeats": 11,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_2.png",
    "weapons": "Axe",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Scale Armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "like King Leonidas: Spartan what is your profession ? HAOU!",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Thurward.png",
    "region": "Berry",
    "pigeon": "Thurward_Berry@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 13,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 13,
    "knightName": "Percyward",
    "age": 28,
    "victories": 2,
    "defeats": 4,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_6.png",
    "weapons": "Sword",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Harness",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "I will be the best !",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Percyward.png",
    "region": "Normaundie",
    "pigeon": "Percyward_Normaundie@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": false,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png",
    "ranking": 23,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 14,
    "knightName": "Autfred",
    "age": 32,
    "victories": 3,
    "defeats": 6,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_2.png",
    "weapons": "Spear",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Breastplate",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "I am not afraid of death !",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Autfred.png",
    "region": "Berry",
    "pigeon": "Autfred_Berry@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 21,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 15,
    "knightName": "Bertlance",
    "age": 43,
    "victories": 25,
    "defeats": 9,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_3.png",
    "weapons": "Mace",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Chainmail",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "Fear me !",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Bertlance.png",
    "region": "Lyonnois",
    "pigeon": "Bertlance_Lyonnois@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 4,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png",
    "successIcons": ""
  },
  {
    "knightId": 16,
    "knightName": "Aeltor",
    "age": 22,
    "victories": 0,
    "defeats": 5,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_4.png",
    "weapons": "Wood stick",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Quilted weave",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "these last words are 'stop it!'",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Aeltor.png",
    "region": "Chaimpaigne",
    "pigeon": "Aeltor_Chaimpaigne@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": false,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png",
    "ranking": 25,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 17,
    "knightName": "Creddred",
    "age": 28,
    "victories": 31,
    "defeats": 0,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_5.png",
    "weapons": "Two handed sword",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Plate armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": true,
    "mountType": "Griffon",
    "mountTypeIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png",
    "mountName": "Ragnar",
    "moto": "Cool, you are food for my pet",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Creddred.png",
    "region": "Languedoc",
    "pigeon": "Creddred_Languedoc@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 1,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_or.png",
    "successIcons": "http://milhiecreation.com/imagesHackaton/success/success_1tournament.png , https://cdn.discordapp.com/attachments/778897010711330846/779148773964120084/success_3tournament.png"
  },
  {
    "knightId": 18,
    "knightName": "Daganho",
    "age": 23,
    "victories": 0,
    "defeats": 0,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_6.png",
    "weapons": "Dague",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Quilted weave",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "Tzi shu force is with me",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Daganho.png",
    "region": "Normaundie",
    "pigeon": "Daganho_Normaundie@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 20,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 19,
    "knightName": "Ethward",
    "age": 29,
    "victories": 15,
    "defeats": 8,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_7.png",
    "weapons": "Bow",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Quilted Weave",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "My arrows are faster than your weapons",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Ethward.png",
    "region": "Orleanois",
    "pigeon": "Ethward_Orleanois@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 9,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png",
    "successIcons": ""
  },
  {
    "knightId": 20,
    "knightName": "Holdjamy",
    "age": 34,
    "victories": 25,
    "defeats": 4,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_8.png",
    "weapons": "Hammer",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Vikings armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": true,
    "mountType": "Wolf",
    "mountTypeIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png",
    "mountName": "Canis",
    "moto": "I have thor's hammer!",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Holdjamy.png",
    "region": "Aquitaine",
    "pigeon": "Holdjamy_Aquitaine@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 2,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_silver.png",
    "successIcons": "http://milhiecreation.com/imagesHackaton/success/success_1tournament.png"
  },
  {
    "knightId": 21,
    "knightName": "Jasmor",
    "age": 31,
    "victories": 8,
    "defeats": 6,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_2.png",
    "weapons": "Scourge",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Scale armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": true,
    "mountType": "Pagasus",
    "mountTypeIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png",
    "mountName": "Pegasus",
    "moto": "My animal is still in the air",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Jasmor.png",
    "region": "Berry",
    "pigeon": "Jasmor_Berry@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 11,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 22,
    "knightName": "Leodagan",
    "age": 25,
    "victories": 15,
    "defeats": 4,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_7.png",
    "weapons": "Axe",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Plate armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": true,
    "mountType": "Hippogriff",
    "mountTypeIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png",
    "mountName": "Buck",
    "moto": "Comme and measure yourself against me",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Leodagan.png",
    "region": "Orleanois",
    "pigeon": "Leodagan_Orleanois@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 5,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_celadon.png",
    "successIcons": ""
  },
  {
    "knightId": 23,
    "knightName": "Lotaut",
    "age": 25,
    "victories": 6,
    "defeats": 4,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_4.png",
    "weapons": "Dagger",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Quited weave",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": true,
    "mountType": "Boar",
    "mountTypeIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png",
    "mountName": "Grouik",
    "moto": "My pet isn't fodd",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Lotaut.png",
    "region": "Chaimpaigne",
    "pigeon": "Lotaut_Chaimpaigne@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 15,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
  },
  {
    "knightId": 24,
    "knightName": "Anosdagan",
    "age": 24,
    "victories": 10,
    "defeats": 1,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_1.png",
    "weapons": "Sword, shield",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Plate armor",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": true,
    "mountType": "Warhorse",
    "mountTypeIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconMount.png",
    "mountName": "Cannasson",
    "moto": "Houra!",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Anosdagan.png",
    "region": "Francie",
    "pigeon": "Anosdagan_Iledefrance@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": true,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconHeartWhite.png",
    "ranking": 3,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_bronze.png",
    "successIcons": "http://milhiecreation.com/imagesHackaton/success/success_1tournament.png"
  },
  {
    "knightId": 25,
    "knightName": "Vallande",
    "age": 26,
    "victories": 18,
    "defeats": 9,
    "banner": "http://milhiecreation.com/imagesHackaton/FinalBanners/banner_7.png",
    "weapons": "Dagger",
    "weaponsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_weapon.png",
    "armors": "Quilted Weave",
    "armorsIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/Icon_armor.png",
    "mount": false,
    "mountType": "",
    "mountTypeIcons": "",
    "mountName": "",
    "moto": "You were born dust and you will be again",
    "avatar": "http://milhiecreation.com/imagesHackaton/Avatar/Vallande.png",
    "region": "Orleanois",
    "pigeon": "Vallande_Orleanois@pigeon.com",
    "pigeonIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconPigeonWhite.png",
    "alive": false,
    "aliveIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconSkullWhite.png",
    "ranking": 14,
    "rankingIcons": "http://milhiecreation.com/imagesHackaton/FinalIcon/IconRank_opaline.png",
    "successIcons": ""
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
      <Link to="/" >
        <h1 className="site-logo">FYT</h1>
      </Link>
      <div className="header-profile">
        <h1>Knight profile</h1>
        <div className="knight-header">
          <img className="avatar-profile" src={knight.avatar} alt="avatar" />
          <div>
            <img className="profile-banner" src={knight.banner} alt="badge" />
          </div>
          <div className="profile">{knight.moto}</div>

        </div>
        <h3 className="profile-title">{knight.knightName}</h3>
        <div className="profile-infos-knight">{knight.age}</div>
        <div className="profile-infos-knight">{knight.alive ? "Alive" : "Dead"}</div>
      </div>

      {/* <div className="profile-container">
        
        
      </div> */}

      <div className="profile-info-container-list">

        <div className="stats-container">
          <h4 className="title-section">My stats</h4>
          <div className="text-card">Rank: {knight.ranking}</div>
          <div className="text-card">Victories: {knight.victories}</div>
          <div className="text-card">Defeats: {knight.defeats}</div>
          <img className="icon-stats" src={knight.rankingIcons} />
          <img className="icon-stats" src={knight.successIcons} />
          {/* <div>
            <img src={knight.badge} alt="badge" />
          </div> */}
        </div>

        <div className="profile-container-list">
          <h4 className="title-section">My caracteristics</h4>
          <div><img src={knight.weaponsIcons} alt="weapons" className="icons" /> : {knight.weapons}</div>
          <div><img src={knight.mountTypeIcons} alt="mount" className="icons" />: {knight.mount ? knight.mountType + "Name:" + knight.mountName : "none"}</div>
          <div><img src={knight.armorsIcons} alt="gear" className="icons" />: {knight.armors}</div>
          <div><img src={knight.pigeonIcons} alt="pigeon" className="icons" />: {knight.pigeon}</div>
        </div>
      </div>
    </div>

  )
}

export default Profile;