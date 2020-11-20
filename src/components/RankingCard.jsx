import React from 'react';
import { Link } from 'react-router-dom';
import "../styles/RankingCard.css";

function RankingCard({ knight }) {

  const { knightId } = knight;

  return (
    <>
      <Link to={`/profile/${knightId}`}>
        <div className="card-ranking-container">

          <div style={{
          backgroundImage: `url(${knight.avatar})`, 
          width: "20vh",
          height: "20vh",
          backgroundSize: "cover",
          backgroundPosition: "center center",
          borderRadius: "50%",
          zIndex: "1",
          }} />
            {/* <img className="avatar-ranking" src={knight.avatar} alt={knight.knightName} /> */}
          <div className="title-ranking">
            <h2>{knight.knightName} </h2>
          </div>
          {/* <div className="results"> */}
          <div className="result">Victories:
          <div className="victories-color">{knight.victories}</div>
          </div>

          <div className="result">Defeats:
          <div className="defeats-color">{knight.defeats}</div>
          </div>
          {/* </div> */}

          <img className="icon-ranking" src={knight.rankingIcons} alt="ranking" />
          <img className="icon-success" 
          src={knight.successIcons ? knight.successIcons : null}  />
          <img className="icon-banner" src={knight.banner} alt="banner" />
          <img className="icon-status" src={knight.aliveIcons} alt="status" />

        </div>
      </Link>
    </>
  )
}

export default RankingCard;