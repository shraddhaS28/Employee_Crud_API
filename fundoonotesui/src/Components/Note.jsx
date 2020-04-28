import React from 'react';
import { Component } from 'react';
import { Card, createMuiTheme, Box, colors } from '@material-ui/core';

export default class Note extends Component{

    render(){
        return(
            <input type='addNote' placeholder='Take Note' />
        )
    }
}