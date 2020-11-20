import React from 'react';
import { BrowserRouter as Router, Route, Switch, Link } from 'react-router-dom';
import './App.css';
import TournamentDetails from "./components/TournamentDetails"
import TournamentsList from './components/TournamentsList';
import Profile from './components/Profile';
import MyProfile from './components/MyProfile';
import RankingList from './components/RankingList'
import NavBar from './components/NavBar';
import Home from './components/Home'
import ScrollToTop from './components/ScrollToTop';
import Footer from './components/Footer';


function App() {
  return (
    <div className="App">
      <main>
        <Router>
          <ScrollToTop />
          <NavBar />
          
          <Switch>
            <Route exact path="/">
              <Link to="/" >
                <h1 className="home-logo">FYT</h1>
              </Link>
              <Home />
            </Route>
            <Route path="/tournaments">
              <TournamentsList />
              <Footer />
            </Route>
            <Route path="/rankings">
              <RankingList />
              <Footer />
            </Route>
            <Route path="/my-profile">
              <MyProfile />
            </Route>
            <Route path="/profile/:id">
              <Profile />
              <Footer />
            </Route>
            <Route path="/tournament/:id">
              <TournamentDetails />
              <Footer />
            </Route>
          </Switch>
        </Router>
      </main>
    </div>
  );
}

export default App;
