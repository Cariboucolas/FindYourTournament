import React from 'react';
import '../styles/TournamentsList.css'
import '../styles/TournamentCard.css'
const TournamentCard = ({tournament}) => {
    const {
        tournamentName, 
        description,
        tournamentLocation,
        images,
    }=tournament;
    return (
        <div className="tournament-card">
            <img className="tournament-img" src={images} alt={tournamentName}/>
            <div className="tournament-info">
                <div>
                    <h2>{tournamentName}</h2>
                    <p>{description}</p>
                    <p>{tournamentLocation}</p>
                </div>
                <div className="view">View</div>
            </div>
        </div>
    );
}

export default TournamentCard;