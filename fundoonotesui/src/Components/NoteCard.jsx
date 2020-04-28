import React, { Component } from 'react';
import Card from '@material-ui/core/Card';
import CardActionArea from '@material-ui/core/CardActionArea';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import Button from '@material-ui/core/Button';
import Typography from '@material-ui/core/Typography';
import DeleteIcon from '@material-ui/icons/Delete';
import EditIcon from '@material-ui/icons/Edit';

export default class NoteCard extends Component {
   state={
       show : false
   }

   showChangeHandler=()=>{
    const shouldShow = this.state.show;   
    this.setState({
        show : !shouldShow
       })
   }
    render() {
        return (
            <div className='notes-display-div'>
                {
                    this.props.notes.map((note, key) => {
                        return (
                            <>
                                <Card className='note-card' key={key}>
                                    <CardActionArea >
                                        <CardContent id='card-content' onClick={this.showChangeHandler}>
                                            <Typography gutterBottom variant="h5" component="h2">
                                                {note.title}
                                            </Typography>
                                            <Typography id='note-content' variant="body 2" color="textSecondary" component="p">
                                                {note.note}
                                            </Typography>
                                        </CardContent>
                                    </CardActionArea>
                                    {
                                        this.state.show ? <CardActions>
                                        <Button variant='contained'
                                            color="white"
                                            startIcon={<EditIcon />}
                                        >
                                        </Button>
                                        <Button
                                            variant="contained"
                                            color="white"
                                            startIcon={<DeleteIcon />}
                                        >
                                        </Button>
                                    </CardActions> : null
                                    } 
                                    
                                </Card>

                            </>
                        )
                    })
                }
            </div>
        );
    }
}
