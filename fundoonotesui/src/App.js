import React from 'react';
import './App.css';
import { Component } from 'react';
import MainPage from './Components/MainPage'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';

class App extends Component{

  // constructor(props) {
  //   super(props)
  // }

  render() {
    return (
      <Router>
        <Switch>
          <Route path='/' component={MainPage} exact />
        </Switch>
      </Router>
    )
  }
}
export default App;
