import React from 'react';
import './App.css';
import { Component } from 'react';
import { Home } from './Components/Home'
import  Login  from './Components/Login'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import EmployeeData from './Components/EmployeeData';

class App extends Component {
  constructor(props) {
    super(props)
  }
  render() {
    return (
      <Router>
        <Switch>
          <Route path='/' component={EmployeeData} exact />
          <Route path='/' component={Login} exact />
          <Route path='/login' component={Login} />
        </Switch>
      </Router>
    );
  }
}


export default App;
