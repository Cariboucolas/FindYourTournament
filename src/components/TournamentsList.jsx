import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';
import TournamentCard from './TournamentCard'

const TournamentsList = () => {

  // const tournamentsArr =
  //   [
  //     {
  //       "tournamentId": 6,
  //       "tournamentName": "Epiphany tournament",
  //       "tournamentDate": "1392-01-06T00:00:00",
  //       "price": 1,
  //       "prize": 100,
  //       "tournamentLocation": "Palace of the Dukes of Bourgogne",
  //       "tournamentType": "Without Mount",
  //       "description": "Epiphany: opening of the Combats, we have been waiting for this since last year",
  //       "participants": 50,
  //       "champion": "",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_6.png",
  //       "videos": ""
  //     },
  //     {
  //       "tournamentId": 3,
  //       "tournamentName": "Spring Tournament",
  //       "tournamentDate": "1392-03-20T00:00:00",
  //       "price": 1,
  //       "prize": 100,
  //       "tournamentLocation": "Castle of Faverges",
  //       "tournamentType": "Without Mount",
  //       "description": "No time to see the tulips bloom, the fights have started again",
  //       "participants": 25,
  //       "champion": "Holdjamy",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_3.png",
  //       "videos": ""
  //     },
  //     {
  //       "tournamentId": 2,
  //       "tournamentName": "Easter tournament",
  //       "tournamentDate": "1392-04-15T00:00:00",
  //       "price": 4,
  //       "prize": 500,
  //       "tournamentLocation": "Castle of Roquetaillade",
  //       "tournamentType": "With mount",
  //       "description": "We are not looking for eggs but for bloodthirsty fighters",
  //       "participants": 50,
  //       "champion": "Anosdagan",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_2.png",
  //       "videos": ""
  //     },
  //     {
  //       "tournamentId": 5,
  //       "tournamentName": "Ascension Tournament",
  //       "tournamentDate": "1392-05-13T00:00:00",
  //       "price": 10,
  //       "prize": 1000,
  //       "tournamentLocation": "Castle of Rouen",
  //       "tournamentType": "With Mount",
  //       "description": "As the symbol of faith expresses it: “He ascended into Heaven; he is seated at the right hand of the Father. He will come again in glory to judge the living and the dead, and his reign will have no end ",
  //       "participants": 75,
  //       "champion": "Asnosdagan",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_5.png",
  //       "videos": ""
  //     },
  //     {
  //       "tournamentId": 7,
  //       "tournamentName": "Pentecote tournament",
  //       "tournamentDate": "1392-05-23T00:00:00",
  //       "price": 50,
  //       "prize": 1000,
  //       "tournamentLocation": "Castle of Courtanvaux",
  //       "tournamentType": "With Mount",
  //       "description": "Commemorates the descent of the Holy Spirit and become an apostle of Jesus Christ",
  //       "participants": 50,
  //       "champion": "",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_7.png",
  //       "videos": ""
  //     },
  //     {
  //       "tournamentId": 4,
  //       "tournamentName": "Mother's Day tournament",
  //       "tournamentDate": "1392-05-30T00:00:00",
  //       "price": 10,
  //       "prize": 250,
  //       "tournamentLocation": "Castle of Veauce",
  //       "tournamentType": "Without Mount",
  //       "description": "Many mothers lose their children during this tournament",
  //       "participants": 30,
  //       "champion": "Creddred",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_4.png",
  //       "videos": ""
  //     },
  //     {
  //       "tournamentId": 8,
  //       "tournamentName": "Assumption tournament",
  //       "tournamentDate": "1392-08-15T00:00:00",
  //       "price": 50,
  //       "prize": 1000,
  //       "tournamentLocation": "Castle of Thorens",
  //       "tournamentType": "With Mount",
  //       "description": "The Assumption of the Blessed Virgin and also of our fighters",
  //       "participants": 100,
  //       "champion": "",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_8.png",
  //       "videos": ""
  //     },
  //     {
  //       "tournamentId": 9,
  //       "tournamentName": "Toussaint tournament",
  //       "tournamentDate": "1392-11-01T00:00:00",
  //       "price": 25,
  //       "prize": 500,
  //       "tournamentLocation": "Castle of Falaise",
  //       "tournamentType": "Without Mount",
  //       "description": "The day after the feast of the dead: enough to honor all these fighters who left too early",
  //       "participants": 100,
  //       "champion": "",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_9.png",
  //       "videos": ""
  //     },
  //     {
  //       "tournamentId": 10,
  //       "tournamentName": "Charles V tournament ",
  //       "tournamentDate": "1392-11-01T00:00:00",
  //       "price": 25,
  //       "prize": 500,
  //       "tournamentLocation": "Castle of Falaise",
  //       "tournamentType": "Without Mount",
  //       "description": "The day after the feast of the dead: enough to honor all these fighters who left too early",
  //       "participants": 100,
  //       "champion": "",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_9.png",
  //       "videos": ""
  //     },
  //     {
  //       "tournamentId": 1,
  //       "tournamentName": "Tournament Of the year : Christmas tournament ",
  //       "tournamentDate": "1392-12-25T00:00:00",
  //       "price": 100,
  //       "prize": 12500,
  //       "tournamentLocation": "Castle of Vincennes",
  //       "tournamentType": "With Mount",
  //       "description": "This is the last tournament of the year, you will have the chance to fight in front of the king in person",
  //       "participants": 100,
  //       "champion": "Creddred",
  //       "images": "http://milhiecreation.com/imagesHackaton/Tournament/Icon_tournament_10.png",
  //       "videos": ""
  //     }
  //   ]

  // tournament state
  const [tournaments, setTournaments] = useState([])
  const url= "https://backhackaton20201120055355.azurewebsites.net/FYT/tournament";

  // axios request to get tournaments
  const getTournaments =()=>{
      axios
          .get(url)
          .then((res)=> setTournaments(res.data))
          .catch((error) => {
              console.error(error);
            });   
  }

  // componentDidMount
  useEffect(() => {
    getTournaments();
    // setTournaments(tournamentsArr)
  }, []);

  return (
    <>
      <Link to="/" >
        <h1 className="site-logo">FYT</h1>
      </Link>
      <h1 className="tournaments">Tournaments</h1>
      <div className="container">
        {tournaments.map(tournament =>
          <TournamentCard tournament={tournament} />
        )}
      </div>

    </>
  );

}

export default TournamentsList;