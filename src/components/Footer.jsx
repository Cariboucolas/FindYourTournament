import React from "react";
import "../styles/Footer.css"

const FooterPage = () => {
  return (
    <div className="footer">
      <div className="footer-items">
        <h3 className="footer-logo">FYT</h3>
        <p className="footer-subtitle">Find your tournament </p>
      </div>
      <ul className="footer-items">
        <h3 className="sub-titles">Explore</h3>
        <li>Home</li>
        <li>My profile</li>
        <li>Rankings</li>
      </ul>
      <ul className="footer-items">
        <h3 className="sub-titles">Legal</h3>
        <li>Terms</li>
        <li>Privacy</li>
      </ul>
    </div>
  );
}

export default FooterPage;