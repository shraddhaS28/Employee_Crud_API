import React, {Component} from 'react';
import Note from './Note';
import Drawer from './Drawer'
import NoteCard from './NoteCard';
import EditNote from './EditNote'

export default class MainPage extends Component{
   
    state = {
        showField: false,
        showEditBox: false,
        searchField: '',
        title: '',
        note: '',
        notes: [],
        id: 0
    }

    showFieldHandler = async () => {
        const doesShowField = this.state.showField;
        await this.setState({
            showField: !doesShowField
        })
    }

    handleClose = async () => {
        const doesShowField = this.state.showField;
        await this.setState({
            showField: !doesShowField
        })
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
 
    saveChangeHandler = async () => {
        let id = this.state.id;
        const title = this.state.title;
        const note = this.state.note;
        const doesShowField = this.state.showField;
        const noteObj = {
            title : title,
            note : note,
            id : id
        }
        const notes = this.state.notes;
        notes.push(noteObj);
        this.setState({
            notes: [...notes],
            showField: !doesShowField,
            title: '',
            note : '',
            id: id+1
           
        })
    }

    deleteNoteHandler=(id)=>{
        let notes = this.state.notes;
        let matchedNotes = notes.filter((unmatchedNotes)=>
        {
            return unmatchedNotes.id !== id
        })
        this.setState({
            notes: [...matchedNotes]
        })
    }

    searchChangeHandler = async (event) =>{
        let searchFields = event.target.value;
        await this.setState({
            searchField: searchFields
        })
    }

    searchHandler= async(event)=>{
        // const searchedTitle = event.target.value;
        let notes = this.state.notes;
        let resultantNotes = notes.filter((ele)=>{
            return ele.title === this.state.searchField
        })
       await this.setState({
            notes: [...resultantNotes]
        })
    }

    EditBoxHandler=()=>{
        const doesShowEditBox = this.state.showEditBox;
        this.setState({
            showEditBox : !doesShowEditBox
        })
    }

    handleEditClose = async () =>{
        const doesShowEditBox = this.state.showEditBox;
        await this.setState({
            showEditBox : !doesShowEditBox
        })  
    }

    render() {
        return(
            <div id='main-div'>
                <Drawer drawerChange={this.drawerChangeHandler}
                    searchHandler = {this.searchHandler}
                    searchChangeHandler = {this.searchChangeHandler}
                />
                <Note 
                noteChangeHandler={this.noteChangeHandler}
                handleClose = {this.handleClose}
                showFieldHandler = {this.showFieldHandler}
                showField = {this.state.showField} 
                titleChangeHandler = {this.titleChangeHandler}
                saveChangeHandler ={this.saveChangeHandler}
                
                />
                <NoteCard notes={this.state.notes} 
                    deleteNoteHandler = {this.deleteNoteHandler}
                    EditBoxHandler = {this.EditBoxHandler}
                />
                <EditNote
                    showEditBox = {this.state.showEditBox}
                    handleEditClose = {this.handleEditClose}
                />
            </div>
        )
    }   
} 