import React from "react";
import "./Footer.css"

const FooterPage = () => {
  return (
    <div className="footer">
      <div className="footer-item">
        <h1>FYT</h1>

        <h2>Find your tournament </h2>
    </div>

          <section className="footer-item">
            <h3>Explore</h3>
            <ul>
              <li>Home</li>
              <li>About</li>
              <li>Capabilities</li>
              <li>Careers</li>
            </ul>
          </section>

          <section class="footer-item">
            <h3>Visit</h3>
        
              <p>Envoy So. California</p>
              <p>34 Tesla, Ste 100</p>
              <p>Irvine, Ca, USA 92618</p>
   

            <h3 class="desktop">New Business</h3>
            <p class="desktop">engage@weareenvoy.com</p>
            <p class="desktop">949.333.3106</p>
          </section>

          <section class="footer-item">
            <h3>New Business</h3>
            <p>Email us</p>
            <p>949.333.3106</p>
          </section>

          <section class="footer-item">
            <h3>Follow</h3>
            <ul>
              <li>Instagram</li>
              <li>Twitter</li>
              <li>LinkedIn</li>
            </ul>
          </section>

          <section class="footer-item">
            <h3>Legal</h3>
            <ul>
              <li>Terms</li>
              <li>Privacy</li>
            </ul>
          </section>
    </div>
  );
}

export default FooterPage;