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
                                            <Typography gutterBottom variant="Bold" component="h2">
                                                {note.title}
                                            </Typography>
                                            <Typography id='note-content' variant="body2" color="textSecondary" component="p">
                                                {note.note}
                                            </Typography>
                                        </CardContent>
                                    </CardActionArea>
                                       <CardActions>

                                       <Button
                                            variant='outlined'
                                            color='default'
                                            startIcon={<AddAlert />}
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
                                        <Button variant='contained'
                                            color="white"
                                            background-width='1px'
                                            startIcon={<Edit />}
                                        >
                                        </Button>
                                        <Button
                                            variant="contained"
                                            color="white"
                                            startIcon={<Delete />}
                                        />
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
