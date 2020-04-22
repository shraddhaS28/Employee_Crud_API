import React, { Component } from 'react';
import MeasureMentUI from './MeasureMentUI';
import LeftBox from './LeftBox';
import RightBox from './RightBox';
import Formula from './Formula';
import logo from '../iconfinder_equal_103540.png'

class QuantityUI extends Component {
    state = {
        showType: false,
        selectTypeLeft: "",
        selectTypeRight: "",
        LeftBox: "",
        RightBox: ""
    }

    measurementTypeHandler = (event) => {
        const type = event.target.value;
        console.log(type);
        if (type === "Length") {
            this.setState({
                showType: true
            })
        }
        else if (type === "Weight") {
            this.setState({
                showType: false
            })
        }
        console.log(this.state.showType);
    }

    selectTypeLeftChangeHandler = (event) => {
        const selectTypeLeft = event.target.value;
        this.setState({
            selectTypeLeft: selectTypeLeft
        })
    }

    selectTypeRightChangeHandler = (event) => {
        const selectTypeRight = event.target.value;
        this.setState({
            selectTypeRight: selectTypeRight
        })
    }

    inputTypeRightChangeHandler = (event) => {
        const inputTypeRight = event.target.value;
        this.setState({
            inputTypeRight: inputTypeRight
        })
    }
    inputTypeLeftChangeHandler = (event) => {
        const inputTypeLeft = event.target.value;
        this.setState({
            inputTypeLeft: inputTypeLeft
        })
        console.log(this.state.inputTypeLeft);
    }

    render() {
        return (
            <div className='container m-5 d-flex' id='main-div'>
                <div className='headline'>
                    <header>Quantity MeasureMent UI</header>
                </div>
                <MeasureMentUI measurementTypeChanged={this.measurementTypeHandler} />
                <div className='row' id='main-typeconversion-div'>
                    <LeftBox inputTypeLeft={this.inputTypeLeftChangeHandler} selectTypeLeft={this.selectTypeLeftChangeHandler} showType={this.state.showType} />
                    <img src={logo} alt="Equals" id="equalIcon"/>
                    <RightBox inputTypeRight={this.inputTypeRightChangeHandler} selectTypeRight={this.selectTypeRightChangeHandler}  valueRight={this.state.inputTypeRight} showType={this.state.showType} />
                </div>
                <div className='formula'>
                    <Formula selectTypeLeft={this.state.selectTypeLeft} selectTypeRight={this.state.selectTypeRight}/>
                </div>
                
            </div>
        )
    }
}
export default QuantityUI; 