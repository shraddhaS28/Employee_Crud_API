import React, { Component } from 'react';
import TextField from '@material-ui/core/TextField';
import Dialog from '@material-ui/core/Dialog';
import { Button } from '@material-ui/core';
import {AddAlert, AddAPhoto, ColorLens, AddCircleOutline}from '@material-ui/icons';

export default class EditNote extends Component {
    render() {
        return (
            <Dialog open={this.props.showEditBox} aria-labelledby="form-dialog-title">
                <div className='edit-note-div'>
                    <TextField id="standard-basic" placeholder="Title" onChange={this.props.titleChangeHandler} />
                    <TextField id="standard-basic" placeholder="Write Here.."  
                        multiline
                        rows={10} 
                        onChange={this.props.noteChangeHandler}    
                    />
                    <div className='note-btn-div'>
                    <div>
                        <Button 
                            variant = 'outlined'
                            color='default'
                            startIcon ={<AddCircleOutline/>}
                            onClick = {this.props.saveChangeHandler}
                        /> 
                        <Button 
                            variant = 'outlined'
                            color='default'
                            startIcon ={<AddAlert/>}
                        />
                        <Button 
                            variant='outlined'
                            color="default"
                            startIcon={<AddAPhoto />}
                        />
                        <Button 
                            variant='outlined'
                            color="default"
                            startIcon={<ColorLens />}
                        />
                        </div>     
                        <div className='sub-btn-div'>               
                        <Button 
                            variant='outlined'
                            color="secondary"
                            onClick={this.props.handleEditClose}>
                            Close
                        </Button>
                        </div>
                    </div>
                </div>
            </Dialog>
        )
    }
}