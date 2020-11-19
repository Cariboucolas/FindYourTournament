import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';


function Profile() {

 const {id} = useParams();
 const [knight, setKnight] = useState([]);

 useEffect(() => {
  
 })

  return (
    <>
      <h1></h1>

      <h3>My stats</h3>

      <h3>Tournaments coming up</h3>
    </>

  )
}

export default Profile;