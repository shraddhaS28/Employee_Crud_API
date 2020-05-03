import React, { Component } from 'react';
import Card from '@material-ui/core/Card';
import CardActionArea from '@material-ui/core/CardActionArea';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import Button from '@material-ui/core/Button';
import Typography from '@material-ui/core/Typography';
import {Delete, Edit, AddAlert, AddAPhoto, ColorLens} from '@material-ui/icons';

export default class NoteCard extends Component {

    render() {
        return (
            <div className='notes-display-div'>
                {
                    this.props.notes.map((note) => {
                        return (
                            <>
                                <Card className='note-card' key={note.id}>
                                    <CardActionArea >
                                        <CardContent id='card-content' >
                                            <Typography  variant="subtitle1" component="h2">
                                                {note.title}
                                            </Typography>
                                            <Typography id='note-content' variant="body2" color="textSecondary" component="p">
                                                {note.note}
                                            </Typography>
                                        </CardContent>
                                    </CardActionArea>
                                       <CardActions className='note-btn-div'>
                                        <div>
                                       <Button
                                            variant='outlined'
                                            color='default'
                                            size='small'
                                            startIcon={<AddAlert />}
                                        />
                                        <Button
                                            variant="outlined"
                                            color="default"
                                            size='small'
                                            startIcon={<Delete />}
                                            onClick={()=>{this.props.deleteNoteHandler(note.id)}}
                                        />
                                        <Button
                                            variant='outlined'
                                            color="default"
                                            size='small'
                                            startIcon={<AddAPhoto />}
                                        />
                                        <Button
                                            variant='outlined'
                                            color="default"
                                            size='small'
                                            startIcon={<ColorLens />}
                                        />
                                        <Button variant='outlined'
                                            color="default"
                                            size='small'
                                            startIcon={<Edit />}
                                            onClick= {this.props.EditBoxHandler}
                                        >
                                        </Button>
                                        </div>
                                    </CardActions>
                                </Card>
                            </>
                        )
                    })
                }
            </div>
        );
    }
}
