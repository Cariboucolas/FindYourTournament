import React from 'react';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import './App.css';
import SearchTournament from './components/SearchTournament';
import Profile from './components/Profile';
import MyProfile from './components/MyProfile';
import RankingList from './components/RankingList'
import Footer from "./components/Footer";
import NavBar from './components/NavBar';
import Home from './components/Home'
import ScrollToTop from './components/ScrollToTop';


function App() {
  return (
    <div className="App">
      <main>
        <Router>
          <ScrollToTop />
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
            <Route path="/my-profile">
              <MyProfile />
            </Route>
            <Route path="/profile/:id" component={Profile} />
          </Switch>
        </Router>
      </main>
      <Footer />
    </div>
  );
}

export default App;
