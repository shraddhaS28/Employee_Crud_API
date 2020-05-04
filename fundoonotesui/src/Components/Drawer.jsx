import React from 'react';
import clsx from 'clsx';
import { makeStyles, useTheme } from '@material-ui/core/styles';
import {Drawer, AppBar, Toolbar,List, CssBaseline, Typography, Divider, IconButton, ListItem, ListItemIcon, ListItemText} from '@material-ui/core';
import {Menu,ChevronLeft, ChevronRight, EmojiObjects,AddAlert,Edit, Archive, Delete, Search} from '@material-ui/icons';
import Button from '@material-ui/core/Button';

const drawerWidth = 240;

const useStyles = makeStyles((theme) => ({
  root: {
    display: 'flex',
  },
  appBar: {
    zIndex: theme.zIndex.drawer + 1,
    transition: theme.transitions.create(['width', 'margin'], {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.leavingScreen,
    }),  
  },
  appBarShift: {
    marginLeft: drawerWidth,
    width: `calc(100% - ${drawerWidth}px)`,
    transition: theme.transitions.create(['width', 'margin'], {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.enteringScreen,
    }),
  },
  menuButton: {
    marginRight: 36,
  },
  hide: {
    display: 'none',
  },
  drawer: {
    width: drawerWidth,
    flexShrink: 0,
    whiteSpace: 'nowrap',
  },
  drawerOpen: {
    width: drawerWidth,
    transition: theme.transitions.create('width', {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.enteringScreen,
    }),
  },
  drawerClose: {
    transition: theme.transitions.create('width', {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.leavingScreen,
    }),
    overflowX: 'hidden',
    width: theme.spacing(7) + 1,
    [theme.breakpoints.up('sm')]: {
      width: theme.spacing(9) + 1,
    },
  },
  toolbar: {
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'flex-end',
    padding: theme.spacing(0, 1),
    // necessary for content to be below app bar
    ...theme.mixins.toolbar,
  },
  content: {
    flexGrow: 1,
    padding: theme.spacing(3),
  },
}));



export default function MiniDrawer(props) {
    const classes = useStyles();
    const theme = useTheme();
    const [open, setOpen] = React.useState(false);
  
    const handleDrawerOpen = () => {
      setOpen(true);
    };
  
    const handleDrawerClose = () => {
      setOpen(false);
    };
  
    return (
      <div className={classes.root}>
        <CssBaseline />
        <AppBar
          id = 'AppHeader'
          position="fixed"
          className={clsx(classes.appBar, {
            [classes.appBarShift]: open,
          })}
        >
          <Toolbar>
          <div className='MainHeader'>
            <IconButton
              color="inherit"
              aria-label="open drawer"
              onClick={handleDrawerOpen}
              edge="start"
              transition= 'width 2s'
              className={clsx(classes.menuButton, {
                [classes.hide]: open,
              })}
            >
            <Menu />
            </IconButton>
              <Typography>Keep Notes</Typography>
              </div>
            <div className='search-div'>
              
              <input id='search' onChange={props.searchChangeHandler} placeholder='Search...' />
              <Button
                color="default"
                startIcon={<Search />}
                onClick = {props.searchHandler}
              />
            </div>

            
          </Toolbar>
        </AppBar> 
        <Drawer
          variant="permanent"
         
          classes={{
            paper: clsx({
              [classes.drawerOpen]: open,
              [classes.drawerClose]: !open,
            }),
          }}
        >
          <div className={classes.toolbar}>
            <IconButton onClick={handleDrawerClose}>
              {theme.direction === 'rtl' ? <ChevronRight /> : <ChevronLeft />}
            </IconButton>
          </div>
          <Divider />
          <List>
            {['Notes', 'Reminders', 'Edit Labels', 'Archive', 'Trash'].map((text, index) => (
              <ListItem button key={text}>
                <ListItemIcon>{
                        index % 10 === 0 ? <EmojiObjects /> : 
                        index % 10 === 1 ?<AddAlert /> :
                        index % 10 === 2 ?<Edit /> :
                        index % 10 === 4 ?<Archive /> :<Delete/>
                    }
                </ListItemIcon>
                <ListItemText primary={text} />
              </ListItem>
            ))}
          </List>
          <Divider />
        </Drawer>
        
      </div>
    );
  }