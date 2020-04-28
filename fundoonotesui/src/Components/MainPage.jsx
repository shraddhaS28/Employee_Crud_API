import React from 'react';
import Note from './Note';

export default class MainPage extends React.Component{
    constructor(props){
        super(props);
        this.state = {
            Notes: []
        }
    }
    noteChangeHandler = (event) => {
       const noteChange = event.target.value;  
       this.setState({
           noteChange: noteChange
       })
    }

    render() {
        return(
            <div id='main-div'>
                <div className='MainHeader'>
                    <h1>Keep Notes</h1>
                </div>
                <Note noteChange={this.noteChangeHandler} />
            </div>
        )
    }
}