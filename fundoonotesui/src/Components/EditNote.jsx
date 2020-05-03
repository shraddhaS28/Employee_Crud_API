import React, { Component } from 'react';
import TextField from '@material-ui/core/TextField';
import Dialog from '@material-ui/core/Dialog';
import { Button } from '@material-ui/core';
import AddAlertIcon from '@material-ui/icons/AddAlert';
import AddAPhotoIcon from '@material-ui/icons/AddAPhoto';
import ColorLensIcon from '@material-ui/icons/ColorLens';
import ClickAwayListener from '@material-ui/core/ClickAwayListener';

class EditDialog extends Component {
    render() {
        return (
            <Dialog open={this.props.showEditDialog} aria-labelledby="form-dialog-title">
                <div className='edit-note-div'>
                    <TextField id="standard-basic" placeholder="Title" onChange={this.props.titleChangeHandler} />
                    <TextField id="standard-basic" placeholder="Write Here.."  
                        multiline
                        rows={10} 
                        onChange={this.props.noteChangeHandler}    
                    />
                    <div className='note-btn-div'>
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
                        <div>               
                        <Button 
                            variant='outlined'
                            color="default" onClick={this.props.handleClose}>
                            Close
                        </Button>
                        </div>
                    </div>
                </div>
            </Dialog>
        )
    }
}
export default EditDialog;