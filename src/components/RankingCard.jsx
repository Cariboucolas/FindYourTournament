import React from 'react';
import { Link } from 'react-router-dom';
import "./RankingCard.css";

function RankingCard({ knight }) {

  const { knightId } = knight;

  return (
    <>
      <Link to={`/profile/${knightId}`}>
        <div className="card-ranking-container">
          <div className="avatar-rank-card">
            <img src={knight.avatar} alt={knight.knightName} />
          </div>
          <div className="knight-infos-rank-card">
            <h2>{knight.knightName} </h2>
            <div>Victories: {knight.victories}</div>
            <div>Defeats: {knight.defeats}</div>
          </div>
          <div className="badge-rank-card">
            <img src={knight.badge} alt="badge level" />
          </div>
        </div>
      </Link>
    </>
  )
}

export default RankingCard;