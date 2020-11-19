import React from 'react';
import {BrowserRouter as Router,
  Route,
  Switch,
} from 'react-router-dom';
import './App.css';
import SearchTournament from './components/SearchTournament';
import Profile from './components/Profile';
import RankingList from './components/RankingList'
import NavBar from './components/NavBar';

const background_image = 'https://i2.wp.com/www.publicmedievalist.com/wp-content/uploads/2019/02/Competitors-lined-up-from-HISTORY’s-Knight-Fight-premiering-Jan-23_PH_Tim-O’Connell-1.jpg?resize=1400%2C840&ssl=1'

function App() {
  return (
    <div className="App">
      
      <Router>
        <div>
          <NavBar />
          <h1 className="home">FYT</h1>  
        </div>
        <div
          style={{ 
            backgroundImage: `url(${background_image})`,
            height: '100vh',
            width: '100%',
            backgroundSize: 'cover',
            backgroundPosition: 'center center'
          }}
         />
        <Switch>
          <Route path="/">
          </Route>
          <Route path="/tournaments">
            <SearchTournament />
          </Route>
          <Route path="/rankings">
            <RankingList />
          </Route>
          <Route path="/profile">
            <Profile />
          </Route>
        </Switch>
      </Router>
    </div>
  );
}

export default App;
