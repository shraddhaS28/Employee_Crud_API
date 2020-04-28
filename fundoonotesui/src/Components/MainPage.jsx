import React from 'react';
import Note from './Note';
import Drawer from './Drawer'

export default class MainPage extends React.Component{
    constructor(props){
        super(props);
        this.state = {
            Notes: []
        }
    }
    noteChangeHandler = (event) => {
      
    }
    drawerChangeHandler = (event) => {
        const drawerChange = event.target.value;
        this.setState({
            drawerChange: drawerChange
        })
    }

    render() {
        return(
            <div id='main-div'>
                
                <Drawer drawerChange={this.drawerChangeHandler} />

                <Note noteChange={this.noteChangeHandler} />
                
            </div>
        )
    }
}