import React from 'react';
import {BrowserRouter as Router,
  Route,
  Switch,
  Link} from 'react-router-dom';
import './App.css';
import SearchTournament from './components/SearchTournament';
import Profile from './components/Profile';
import RankingList from './components/RankingList'

function App() {
  return (
    <div className="App">
      <Router>
        <Link exact path to="/">
          Home
        </Link>
        <Link exact path to="tournaments">
          Tournaments
        </Link>
        <Link exact path to="/rankings">
          Rankings
        </Link>
        <Link exact path to="/profile">
          Profile
        </Link>
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
