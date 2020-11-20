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
                    <h2 className="name">{tournamentName}</h2>
                    <p className="description">{description}</p>
                    <p className="location">{tournamentLocation}</p>
                </div>
                <div className="view">View</div>
            </div>
        </div>
    );
}

export default TournamentCard;