import React from 'react';
import { Link } from 'react-router-dom';
import '../styles/TournamentsList.css'
import '../styles/TournamentCard.css'

const TournamentCard = ({tournament}) => {
    const {
        tournamentName, 
        description,
        tournamentLocation,
        images,
        tournamentId
    }=tournament;

    return (
        <div className="tournament-card">
            <img className="tournament-img" src={images} alt={tournamentName}/>
            <div className="tournament-info">
                <div>
                    <h3 className="tournament-name">{tournamentName}</h3>
                    <p className="description">{description}</p>
                    <p className="location">{tournamentLocation}</p>
                </div>
                <Link to={`/tournament/${tournamentId}`} >
                <div className="view">View</div>
                </Link>

            </div>
        </div>
    );
}

export default TournamentCard;