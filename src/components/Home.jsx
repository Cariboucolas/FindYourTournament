import React from "react";
import '../styles/Home.css'
import splash from'../splash.svg';

// const background_image = 'https://i2.wp.com/www.publicmedievalist.com/wp-content/uploads/2019/02/Competitors-lined-up-from-HISTORY’s-Knight-Fight-premiering-Jan-23_PH_Tim-O’Connell-1.jpg?resize=1400%2C840&ssl=1'

function Home() {

  return (
    <>
      <div class="lightning flashit content ">
        <p className="slogan">Fight to the Death</p>
      </div>
      <img  fill="red" stroke="green" class="splatter" src={splash} alt="splash"></img>
    </>
  )
}

export default Home;
