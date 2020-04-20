import React, { Component } from 'react';
class MeasurementUI extends Component {
    
    render() {
        return (
            <select name="MeasurementUI" id="measurementType" className=' form-control'  onChange={this.props.measurementTypeChanged}>
                <option value="-1" selected>Select</option>
                <option name="length">Length</option>
                <option name="weight">Weight</option>
            </select>
        )
    }

}

export default MeasurementUI;