
import React from 'react';
import { slide as Menu } from 'react-burger-menu'
import { Link } from 'react-router-dom';
import '../styles/NavBar.css'

class NavBar extends React.Component {
  constructor(props) {
    super(props)
    this.state = {
      menuOpen: false
    }
  }

  // This keeps your state in sync with the opening/closing of the menu
  // via the default means, e.g. clicking the X, pressing the ESC key etc.
  handleStateChange(state) {
    this.setState({ menuOpen: state.isOpen })
  }

  // This can be used to close the menu, e.g. when a user clicks a menu item
  closeMenu() {
    this.setState({ menuOpen: false })
  }

  // This can be used to toggle the menu, e.g. when using a custom icon
  // Tip: You probably want to hide either/both default icons if using a custom icon
  // See https://github.com/negomi/react-burger-menu#custom-icons
  toggleMenu() {
    this.setState(state => ({ menuOpen: !state.menuOpen }))
  }

  showSettings(event) {
    event.preventDefault();

  }

  render() {
    // NOTE: You also need to provide styles, see https://github.com/negomi/react-burger-menu#styling
    return (
      <Menu
        isOpen={this.state.menuOpen}
        onStateChange={(state) => this.handleStateChange(state)}
      >
        <Link to="/" >
          <h1 
            className="navbar-logo" 
            onClick={() => this.closeMenu()}>
            FYT
          </h1>
        </Link>
        <Link
          id="about"
          className="menu-item"
          onClick={() => this.closeMenu()}
          to="/tournaments">
          Tournaments
        </Link>
        <Link
          id="contact"
          className="menu-item"
          onClick={() => this.closeMenu()}
          to="/rankings">
          Rankings
        </Link>
        <Link
          id="contact"
          className="menu-item"
          onClick={() => this.closeMenu()}
          to="/my-profile">
          My profile
        </Link>
        <Link
          onClick={this.showSettings}
          className="menu-item"
          to="/settings">
          Settings
        </Link>
      </Menu>
    );
  }
}

export default NavBar;