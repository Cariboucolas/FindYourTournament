import React from 'react';

const TournamentCard = ({tournament}) => {
    const {
        tournamentName, 
        description,
        tournamentLocation,
    }=tournament;
    return (
        <>
            <h2>{tournamentName}</h2>
            <p>{description}</p>
            <p>{tournamentLocation}</p>
        </>
    );
}

export default TournamentCard;