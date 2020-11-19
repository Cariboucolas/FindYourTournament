import React from 'react';
import {BrowserRouter as Router, Route, Switch, Link} from 'react-router-dom';
import './App.css';
import SearchTournament from './components/SearchTournament';
import Profile from './components/Profile';
import RankingList from './components/RankingList'
import Footer from "./components/Footer";
import NavBar from './components/NavBar';
import Home from './components/Home'


function App() {
  return (
    <div className="App">
      
      <Router>
          <NavBar />        
        <Switch>
          <Route exact path="/">
          <Home />
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
      {/* <Footer /> */}
    </div>
  );
}

export default App;
