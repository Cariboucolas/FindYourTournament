import React, {useState, useEffect} from 'react';
// import axios from 'axios';
import TournamentCard from './TournamentCard'

const TournamentsList = () => {

    const tournamentsArr=
    [
        {
          "tournamentId": 1,
          "tournamentName": "Tournoi N°1",
          "tournamentDate": "1392-01-15T00:00:00",
          "price": 2,
          "prize": 100,
          "tournamentLocation": "Chateau de Versailles",
          "tournamentType": "Au sol",
          "description": "Viens de friter contre ton rival",
          "participants": 25,
          "champion": "",
          "images": "",
          "videos": ""
        },
        {
          "tournamentId": 4,
          "tournamentName": "Tournoi N°4",
          "tournamentDate": "1392-01-15T00:00:00",
          "price": 100,
          "prize": 2500,
          "tournamentLocation": "Le château de Fontainebleau.",
          "tournamentType": "Au sol",
          "description": "Affronte les plus grands adversaire du moment !",
          "participants": 10,
          "champion": "",
          "images": "",
          "videos": ""
        },
        {
          "tournamentId": 3,
          "tournamentName": "Tournoi N°3",
          "tournamentDate": "1392-01-22T00:00:00",
          "price": 0,
          "prize": 50,
          "tournamentLocation": "Chateau d'eau",
          "tournamentType": "Au sol",
          "description": "Initiation",
          "participants": 100,
          "champion": "",
          "images": "",
          "videos": ""
        },
        {
          "tournamentId": 2,
          "tournamentName": "Tournoi N°2",
          "tournamentDate": "1392-03-11T00:00:00",
          "price": 5,
          "prize": 200,
          "tournamentLocation": "Chateau de Colas",
          "tournamentType": "Cheval",
          "description": "Viens labourer la pelouse",
          "participants": 10,
          "champion": "",
          "images": "",
          "videos": ""
        }
    ]

    // tournament state
    const  [tournaments, setTournaments]=useState([])
    // const url= "";

    // // axios request to get tournaments
    // const getTournaments =()=>{
    //     axios
    //         .get(url)
    //         .then((res)=> setTournaments(res.data))
    //         .catch((error) => {
    //             console.error(error);
    //           });   
    // }
    
    // componentDidMount
    useEffect(()=>{
        // getTournaments();
        setTournaments(tournamentsArr)
    },[]);

    return (
        <>
            <div>test</div>
            {tournaments.map(tournament => 
                <TournamentCard tournament={tournament} />
            )}
        </>
    );
}

export default TournamentsList;