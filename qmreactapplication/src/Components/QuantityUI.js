import React, { Component } from 'react';
import MeasureMentUI from './MeasureMentUI';
import LeftBox from './LeftBox';
import RightBox from './RightBox';
import formula from './Formula';

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
            console.log('inside length');
            this.setState({
                showType: true
            })
        }
        else if (type === "Weight") {
            console.log('inside weight');
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
        console.log(this.state.selectTypeLeft);
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
        //const input = this.state.inputTypeLeft;
        // const data = {
        //     Feet: input
        // }
    }

    render() {
        return (
            <div className='container m-5 d-flex justify-content-center' id='main-div'>
                <MeasureMentUI measurementTypeChanged={this.measurementTypeHandler} />
                <div className='row' id='main-typeconversion-div'>
                    <LeftBox inputTypeLeft={this.inputTypeLeftChangeHandler} selectTypeLeft={this.selectTypeLeftChangeHandler} showType={this.state.showType} />
                    <RightBox inputTypeRight={this.inputTypeRightChangeHandler} selectTypeRight={this.selectTypeRightChangeHandler}  valueRight={this.state.inputTypeRight} showType={this.state.showType} />
                </div>
                <div>
                <formula>Formula:</formula>
                </div>
                
            </div>
        )
    }
}
export default QuantityUI; 