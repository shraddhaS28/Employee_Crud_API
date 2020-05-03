import React, { Component } from 'react';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';
import {AddAlert, AddAPhoto, ColorLens, AddCircleOutline}from '@material-ui/icons';
import ClickAwayListener from '@material-ui/core/ClickAwayListener'

export default class Note extends Component{

    render(){
        return (
            <>
                <div className='note-div'>
                    <div>
                    
                    <TextField className='take-note' id="standard-basic" style={{display:  this.props.showField ? 'none' : 'block' }} onClick={this.props.showFieldHandler} placeholder='Take Note...' />
                    {
                        this.props.showField ?
                        <ClickAwayListener onClickAway={this.props.saveChangeHandler}>
                        <div className='title-note-div'>
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
                                onClick={this.props.handleClose}>
                                Close
                                </Button>
                                </div>
                        </div>
                        </div>
                        </ClickAwayListener>
                         : null 
                        }
                      </div>
                    </div>  

                
            </>
        )
    }
}