import React from "react";
import "./Footer.css"

const FooterPage = () => {
  return (
    <div className="footer">
      <div className="footer-items">
        <h1 className="home-logo">FYT</h1>
        <h3 className="footer-subtitle">Find your tournament </h3>
      </div>
      <div className="footer-items">
        <h3>Explore</h3>
        <ul>Home</ul>
        <ul>My profile</ul>
        <ul>Rankings</ul>
      </div>
      <div className="footer-items">
        <h3>Legal</h3>
        <ul>Terms</ul>
        <ul>Privacy</ul>
      </div>
    </div>
  );
}

export default FooterPage;