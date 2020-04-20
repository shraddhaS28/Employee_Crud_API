import React, { Component } from 'react';
class InputTypeRight extends Component{
    render(){
        return(
            <div className='col-md m-5' id='main-label'>
                <input type='text' className="form-control form-control-md" onChange={this.props.inputTypeRight} value={this.props.valueRight} />
                <select name="measurementType" id="measurementType" className='form-control'  onChange={this.props.selectTypeRight}>
                <option value="-1" selected>Select</option>
                
                {
                    this.props.showType?
                    <>
                <option name="length">Feet</option>
                <option name="weight">Inch</option>
                <option name="weight">meter</option>
                <option name="weight">centimeter</option></> : <>
                <option name="weight">Kilogram</option>
                <option name="weight">Gram</option>
                </>
                }
                </select>
            </div>
        )
    }
}
export default InputTypeRight;