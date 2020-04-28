import React, { Component } from 'react';
import NoteCard from './NoteCard';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogTitle from '@material-ui/core/DialogTitle';
import NoteAddIcon from '@material-ui/icons/NoteAdd';

export default class Note extends Component{

    state = {
        open: false,
        title: '',
        note: '',
        notes: []
    }

    handleClickOpen = async () => {
        const doesOpen = this.state.open;
        await this.setState({
            open: !doesOpen
        })
    };

    handleClose = async () => {
        const doesOpen = this.state.open
        await this.setState({
            open: !doesOpen
        })
        console.log(this.state.open);
    };

    titleChangeHandler = (event) => {
        const title = event.target.value;
        this.setState({
            title: title
        })

    }

    noteChangeHandler = (event) => {
        const note = event.target.value;
        this.setState({
            note: note
        })

    }

    saveChangeHandler = () => {
        const title = this.state.title;
        const note = this.state.note;
        const doesOpen = this.state.open;
        const noteObj = {
            title: title,
            note: note
        }
        const notes = this.state.notes;
        notes.push(noteObj);
        this.setState({
            notes: [...notes],
            open: !doesOpen
        })
    }

    render(){
        return (
            <>
                <div className='note-div'>
                    <Button id='note-button' startIcon={<NoteAddIcon/>}   onClick={this.handleClickOpen}>
                        Take a Note ...
                    </Button>
                </div>
                    <Dialog open={this.state.open} onClose={this.handleClose} aria-labelledby="form-dialog-title">
                    <DialogTitle id="form-dialog-title">Note</DialogTitle>
                    <DialogContent>
                        <TextField
                            autoFocus
                            margin="dense"
                            id="name"
                            label="Title"
                            fullWidth
                            onChange={this.titleChangeHandler}
                        />
                    </DialogContent>
                    
                    <DialogContent>
                        <TextField
                            autoFocus
                            multiline
                            rows={10}
                            placeholder="Write Here..."
                            fullWidth
                            onChange={this.noteChangeHandler}
                        />
                    </DialogContent>
                    <DialogActions>
                        <Button variant='contained' onClick={this.handleClose} color="black">
                            Cancel
                        </Button>
                        <Button variant='contained' onClick={this.saveChangeHandler} color="black">
                            Save
                            </Button>
                    </DialogActions>
                   
                </Dialog>
                
                <NoteCard notes={this.state.notes}/>
            </>
        )
    }
}