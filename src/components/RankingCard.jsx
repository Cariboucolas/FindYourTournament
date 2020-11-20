import React from 'react';
import { Link } from 'react-router-dom';
import "../styles/RankingCard.css";

function RankingCard({ knight }) {

  const { knightId } = knight;

  return (
    <>
      <Link to={`/profile/${knightId}`}>
        <div className="card-ranking-container">
          <div className="avatar-rank-card">
            <img src={knight.avatar} alt={knight.knightName} />
          </div>
          <h2>{knight.knightName} </h2>
          <div>Victories:
          <div className="victories-color">{knight.victories}</div>
          </div>
          <div>Defeats:
          <div className="defeats-color">{knight.defeats}</div>
          </div>
          <div className="badge-rank-card">
            <img src={knight.ranking} alt="rank" />
          </div>
          <div className="badge-rank-card">
            <img src={knight.RankingIcons} alt="level" />
          </div>
          <div className="badge-rank-card">
            <img src={knight.banner} alt="banner" />
          </div>
          <div className="status">
            <img src={knight.alive} alt="status" />
          </div>
        </div>
      </Link>
    </>
  )
}

export default RankingCard;