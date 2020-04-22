import React, { Component } from 'react';
class RightBox extends Component{
    render(){
        return(
            <div className='col-md m-5' id='main-label'>
                <input type='text' className="form-control form-control-md" onChange={this.props.RightBox} value={this.props.valueRight} />
                <select name="measurementType" id="measurementType" className='form-control'  onChange={this.props.selectTypeRight}>
                <option value="-1" selected>Select</option>``
                
                {
                    this.props.showType?
                    <>
                <option name="length">Feet</option>
                <option name="weight">Inch</option>
                <option name="weight">Meter</option>
                <option name="weight">Centimeter</option></> : <>
                <option name="weight">Kilogram</option>
                <option name="weight">Gram</option>
                </>
                }
                </select>
            </div>
        )
    }
}
export default RightBox;